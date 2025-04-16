<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models;

use AlibabaCloud\Tea\Model;
use GuzzleHttp\Psr7\Stream;

class Message extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var Recipient[]
     */
    public $bccRecipients;

    /**
     * @description This parameter is required.
     *
     * @var Recipient[]
     */
    public $ccRecipients;

    /**
     * @description This parameter is required.
     *
     * @example conversationid
     *
     * @var Stream
     */
    public $conversationId;

    /**
     * @description This parameter is required.
     *
     * @example 2
     *
     * @var Stream
     */
    public $folderId;

    /**
     * @description This parameter is required.
     *
     * @var Recipient
     */
    public $from;

    /**
     * @description This parameter is required.
     *
     * @example false
     *
     * @var bool
     */
    public $hasAttachments;

    /**
     * @description This parameter is required.
     *
     * @example mailid
     *
     * @var Stream
     */
    public $id;

    /**
     * @description This parameter is required.
     *
     * @example 由RFC5322定义的邮件头集合
     *
     * @var mixed[]
     */
    public $internetMessageHeaders;

    /**
     * @description This parameter is required.
     *
     * @example uniqid@dingtalk.com
     *
     * @var Stream
     */
    public $internetMessageId;

    /**
     * @description This parameter is required.
     *
     * @example false
     *
     * @var bool
     */
    public $isForwarded;

    /**
     * @description This parameter is required.
     *
     * @example false
     *
     * @var bool
     */
    public $isRead;

    /**
     * @description This parameter is required.
     *
     * @example false
     *
     * @var bool
     */
    public $isReadReceiptRequested;

    /**
     * @description This parameter is required.
     *
     * @example false
     *
     * @var bool
     */
    public $isReplied;

    /**
     * @description This parameter is required.
     *
     * @example 2024-10-01T00:00:00Z
     *
     * @var Stream
     */
    public $lastModifiedDateTime;

    /**
     * @description This parameter is required.
     *
     * @example PRY_NORMAL
     *
     * @var Stream
     */
    public $priority;

    /**
     * @description This parameter is required.
     *
     * @example 2024-10-01T00:00:00Z
     *
     * @var Stream
     */
    public $receivedDateTime;

    /**
     * @description This parameter is required.
     *
     * @var Recipient
     */
    public $replyTo;

    /**
     * @description This parameter is required.
     *
     * @example 2024-10-01T00:00:00Z
     *
     * @var Stream
     */
    public $sentDateTime;

    /**
     * @description This parameter is required.
     *
     * @example 主题
     *
     * @var Stream
     */
    public $subject;

    /**
     * @description This parameter is required.
     *
     * @example 一般取邮件正文的前一段
     *
     * @var Stream
     */
    public $summary;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $tags;

    /**
     * @description This parameter is required.
     *
     * @var Recipient[]
     */
    public $toRecipients;
    protected $_name = [
        'bccRecipients' => 'bccRecipients',
        'ccRecipients' => 'ccRecipients',
        'conversationId' => 'conversationId',
        'folderId' => 'folderId',
        'from' => 'from',
        'hasAttachments' => 'hasAttachments',
        'id' => 'id',
        'internetMessageHeaders' => 'internetMessageHeaders',
        'internetMessageId' => 'internetMessageId',
        'isForwarded' => 'isForwarded',
        'isRead' => 'isRead',
        'isReadReceiptRequested' => 'isReadReceiptRequested',
        'isReplied' => 'isReplied',
        'lastModifiedDateTime' => 'lastModifiedDateTime',
        'priority' => 'priority',
        'receivedDateTime' => 'receivedDateTime',
        'replyTo' => 'replyTo',
        'sentDateTime' => 'sentDateTime',
        'subject' => 'subject',
        'summary' => 'summary',
        'tags' => 'tags',
        'toRecipients' => 'toRecipients',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bccRecipients) {
            $res['bccRecipients'] = [];
            if (null !== $this->bccRecipients && \is_array($this->bccRecipients)) {
                $n = 0;
                foreach ($this->bccRecipients as $item) {
                    $res['bccRecipients'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->ccRecipients) {
            $res['ccRecipients'] = [];
            if (null !== $this->ccRecipients && \is_array($this->ccRecipients)) {
                $n = 0;
                foreach ($this->ccRecipients as $item) {
                    $res['ccRecipients'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->conversationId) {
            $res['conversationId'] = $this->conversationId;
        }
        if (null !== $this->folderId) {
            $res['folderId'] = $this->folderId;
        }
        if (null !== $this->from) {
            $res['from'] = null !== $this->from ? $this->from->toMap() : null;
        }
        if (null !== $this->hasAttachments) {
            $res['hasAttachments'] = $this->hasAttachments;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->internetMessageHeaders) {
            $res['internetMessageHeaders'] = $this->internetMessageHeaders;
        }
        if (null !== $this->internetMessageId) {
            $res['internetMessageId'] = $this->internetMessageId;
        }
        if (null !== $this->isForwarded) {
            $res['isForwarded'] = $this->isForwarded;
        }
        if (null !== $this->isRead) {
            $res['isRead'] = $this->isRead;
        }
        if (null !== $this->isReadReceiptRequested) {
            $res['isReadReceiptRequested'] = $this->isReadReceiptRequested;
        }
        if (null !== $this->isReplied) {
            $res['isReplied'] = $this->isReplied;
        }
        if (null !== $this->lastModifiedDateTime) {
            $res['lastModifiedDateTime'] = $this->lastModifiedDateTime;
        }
        if (null !== $this->priority) {
            $res['priority'] = $this->priority;
        }
        if (null !== $this->receivedDateTime) {
            $res['receivedDateTime'] = $this->receivedDateTime;
        }
        if (null !== $this->replyTo) {
            $res['replyTo'] = null !== $this->replyTo ? $this->replyTo->toMap() : null;
        }
        if (null !== $this->sentDateTime) {
            $res['sentDateTime'] = $this->sentDateTime;
        }
        if (null !== $this->subject) {
            $res['subject'] = $this->subject;
        }
        if (null !== $this->summary) {
            $res['summary'] = $this->summary;
        }
        if (null !== $this->tags) {
            $res['tags'] = $this->tags;
        }
        if (null !== $this->toRecipients) {
            $res['toRecipients'] = [];
            if (null !== $this->toRecipients && \is_array($this->toRecipients)) {
                $n = 0;
                foreach ($this->toRecipients as $item) {
                    $res['toRecipients'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return Message
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bccRecipients'])) {
            if (!empty($map['bccRecipients'])) {
                $model->bccRecipients = [];
                $n = 0;
                foreach ($map['bccRecipients'] as $item) {
                    $model->bccRecipients[$n++] = null !== $item ? Recipient::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['ccRecipients'])) {
            if (!empty($map['ccRecipients'])) {
                $model->ccRecipients = [];
                $n = 0;
                foreach ($map['ccRecipients'] as $item) {
                    $model->ccRecipients[$n++] = null !== $item ? Recipient::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['conversationId'])) {
            $model->conversationId = $map['conversationId'];
        }
        if (isset($map['folderId'])) {
            $model->folderId = $map['folderId'];
        }
        if (isset($map['from'])) {
            $model->from = Recipient::fromMap($map['from']);
        }
        if (isset($map['hasAttachments'])) {
            $model->hasAttachments = $map['hasAttachments'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['internetMessageHeaders'])) {
            $model->internetMessageHeaders = $map['internetMessageHeaders'];
        }
        if (isset($map['internetMessageId'])) {
            $model->internetMessageId = $map['internetMessageId'];
        }
        if (isset($map['isForwarded'])) {
            $model->isForwarded = $map['isForwarded'];
        }
        if (isset($map['isRead'])) {
            $model->isRead = $map['isRead'];
        }
        if (isset($map['isReadReceiptRequested'])) {
            $model->isReadReceiptRequested = $map['isReadReceiptRequested'];
        }
        if (isset($map['isReplied'])) {
            $model->isReplied = $map['isReplied'];
        }
        if (isset($map['lastModifiedDateTime'])) {
            $model->lastModifiedDateTime = $map['lastModifiedDateTime'];
        }
        if (isset($map['priority'])) {
            $model->priority = $map['priority'];
        }
        if (isset($map['receivedDateTime'])) {
            $model->receivedDateTime = $map['receivedDateTime'];
        }
        if (isset($map['replyTo'])) {
            $model->replyTo = Recipient::fromMap($map['replyTo']);
        }
        if (isset($map['sentDateTime'])) {
            $model->sentDateTime = $map['sentDateTime'];
        }
        if (isset($map['subject'])) {
            $model->subject = $map['subject'];
        }
        if (isset($map['summary'])) {
            $model->summary = $map['summary'];
        }
        if (isset($map['tags'])) {
            if (!empty($map['tags'])) {
                $model->tags = $map['tags'];
            }
        }
        if (isset($map['toRecipients'])) {
            if (!empty($map['toRecipients'])) {
                $model->toRecipients = [];
                $n = 0;
                foreach ($map['toRecipients'] as $item) {
                    $model->toRecipients[$n++] = null !== $item ? Recipient::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
