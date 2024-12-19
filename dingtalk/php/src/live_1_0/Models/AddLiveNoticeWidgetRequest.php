<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddLiveNoticeWidgetRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $iconUrl;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $jumpUrl;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $liveId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $noticeText;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'iconUrl'    => 'iconUrl',
        'jumpUrl'    => 'jumpUrl',
        'liveId'     => 'liveId',
        'noticeText' => 'noticeText',
        'unionId'    => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->iconUrl) {
            $res['iconUrl'] = $this->iconUrl;
        }
        if (null !== $this->jumpUrl) {
            $res['jumpUrl'] = $this->jumpUrl;
        }
        if (null !== $this->liveId) {
            $res['liveId'] = $this->liveId;
        }
        if (null !== $this->noticeText) {
            $res['noticeText'] = $this->noticeText;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddLiveNoticeWidgetRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['iconUrl'])) {
            $model->iconUrl = $map['iconUrl'];
        }
        if (isset($map['jumpUrl'])) {
            $model->jumpUrl = $map['jumpUrl'];
        }
        if (isset($map['liveId'])) {
            $model->liveId = $map['liveId'];
        }
        if (isset($map['noticeText'])) {
            $model->noticeText = $map['noticeText'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
