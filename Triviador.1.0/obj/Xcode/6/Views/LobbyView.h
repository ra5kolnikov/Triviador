// WARNING
// This file has been generated automatically by Visual Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <AppKit/AppKit.h>


@interface LobbyView : NSViewController {
	NSButton *_BackButton;
	NSTextField *_LobbyTF;
}

@property (nonatomic, retain) IBOutlet NSButton *BackButton;

@property (nonatomic, retain) IBOutlet NSTextField *LobbyTF;

- (IBAction)BackButtonPressed:(NSButton *)sender;

@end
