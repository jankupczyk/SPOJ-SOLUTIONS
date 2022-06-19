import numbers



numbers = input("")

numbersArray = []

for number in numbers:
    numbersArray.append(number)

class Node:
	def __init__(self, key):
		self.left = None
		self.right = None
		self.val = key


def insert(root, key):
	if root is None:
		return Node(key)
	else:
		if root.val == key:
			return root
		elif root.val < key:
			root.right = insert(root.right, key)
		else:
			root.left = insert(root.left, key)
	return root


def inorder(root):
	if root:
		inorder(root.left)
		print(root.val)
		inorder(root.right)

def postorder(root):
	if root:
		postorder(root.left)
		postorder(root.right)
		print(root.val)

def preorder(root):
	if root:
		print(root.val)
		preorder(root.left)
		preorder(root.right)

print(f'\nPre order : {preorder(number)}')
print(f'\nIn order : {inorder(number)}')
print(f'\nPost order : {postorder(number)}')
