<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateCardRequest;

use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateCardRequest\imGroupOpenSpaceModel\notification;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateCardRequest\imGroupOpenSpaceModel\searchSupport;
use AlibabaCloud\Tea\Model;

class imGroupOpenSpaceModel extends Model
{
    /**
     * @description 支持国际化的LastMessage
     * 越南语: VI_VN
     * @var string[]
     */
    public $lastMessageI18n;

    /**
     * @description 卡片的通知属性信息
     *
     * @var notification
     */
    public $notification;

    /**
     * @description 支持卡片消息可被搜索字段
     *
     * @var searchSupport
     */
    public $searchSupport;

    /**
     * @description 是否支持转发, 默认 false
     *
     * @var bool
     */
    public $supportForward;
    protected $_name = [
        'lastMessageI18n' => 'lastMessageI18n',
        'notification'    => 'notification',
        'searchSupport'   => 'searchSupport',
        'supportForward'  => 'supportForward',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->lastMessageI18n) {
            $res['lastMessageI18n'] = $this->lastMessageI18n;
        }
        if (null !== $this->notification) {
            $res['notification'] = null !== $this->notification ? $this->notification->toMap() : null;
        }
        if (null !== $this->searchSupport) {
            $res['searchSupport'] = null !== $this->searchSupport ? $this->searchSupport->toMap() : null;
        }
        if (null !== $this->supportForward) {
            $res['supportForward'] = $this->supportForward;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return imGroupOpenSpaceModel
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['lastMessageI18n'])) {
            $model->lastMessageI18n = $map['lastMessageI18n'];
        }
        if (isset($map['notification'])) {
            $model->notification = notification::fromMap($map['notification']);
        }
        if (isset($map['searchSupport'])) {
            $model->searchSupport = searchSupport::fromMap($map['searchSupport']);
        }
        if (isset($map['supportForward'])) {
            $model->supportForward = $map['supportForward'];
        }

        return $model;
    }
}
