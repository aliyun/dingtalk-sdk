<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\HrmMailSendRequest;

use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\HrmMailSendRequest\mail\attachments;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\HrmMailSendRequest\mail\meeting;
use AlibabaCloud\Tea\Model;

class mail extends Model
{
    /**
     * @var attachments[]
     */
    public $attachments;

    /**
     * @example abd@aaa.com,bcd@aaa.com,
     *
     * @var string
     */
    public $bccAddress;

    /**
     * @example abd@aaa.com,bcd@aaa.com,
     *
     * @var string
     */
    public $ccAddress;

    /**
     * @description This parameter is required.
     *
     * @example 请及时填写请填写入职登记表
     *
     * @var string
     */
    public $content;

    /**
     * @var meeting
     */
    public $meeting;

    /**
     * @description This parameter is required.
     *
     * @example abd@aaa.com,bcd@aaa.com,
     *
     * @var string
     */
    public $receiverAddress;

    /**
     * @description This parameter is required.
     *
     * @example 智能人事入职
     *
     * @var string
     */
    public $senderAlias;

    /**
     * @description This parameter is required.
     *
     * @example 请填写入职登记表
     *
     * @var string
     */
    public $subject;
    protected $_name = [
        'attachments'     => 'attachments',
        'bccAddress'      => 'bccAddress',
        'ccAddress'       => 'ccAddress',
        'content'         => 'content',
        'meeting'         => 'meeting',
        'receiverAddress' => 'receiverAddress',
        'senderAlias'     => 'senderAlias',
        'subject'         => 'subject',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->attachments) {
            $res['attachments'] = [];
            if (null !== $this->attachments && \is_array($this->attachments)) {
                $n = 0;
                foreach ($this->attachments as $item) {
                    $res['attachments'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->bccAddress) {
            $res['bccAddress'] = $this->bccAddress;
        }
        if (null !== $this->ccAddress) {
            $res['ccAddress'] = $this->ccAddress;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->meeting) {
            $res['meeting'] = null !== $this->meeting ? $this->meeting->toMap() : null;
        }
        if (null !== $this->receiverAddress) {
            $res['receiverAddress'] = $this->receiverAddress;
        }
        if (null !== $this->senderAlias) {
            $res['senderAlias'] = $this->senderAlias;
        }
        if (null !== $this->subject) {
            $res['subject'] = $this->subject;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return mail
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attachments'])) {
            if (!empty($map['attachments'])) {
                $model->attachments = [];
                $n                  = 0;
                foreach ($map['attachments'] as $item) {
                    $model->attachments[$n++] = null !== $item ? attachments::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['bccAddress'])) {
            $model->bccAddress = $map['bccAddress'];
        }
        if (isset($map['ccAddress'])) {
            $model->ccAddress = $map['ccAddress'];
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['meeting'])) {
            $model->meeting = meeting::fromMap($map['meeting']);
        }
        if (isset($map['receiverAddress'])) {
            $model->receiverAddress = $map['receiverAddress'];
        }
        if (isset($map['senderAlias'])) {
            $model->senderAlias = $map['senderAlias'];
        }
        if (isset($map['subject'])) {
            $model->subject = $map['subject'];
        }

        return $model;
    }
}
