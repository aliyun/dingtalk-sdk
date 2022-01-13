<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SendMsgByTaskRequest\sendConfig;

use AlibabaCloud\Tea\Model;

class urlTrackConfig extends Model
{
    /**
     * @description 跟踪链接URL
     *
     * @var string
     */
    public $trackUrl;

    /**
     * @description 跟踪链接的标题
     *
     * @var string
     */
    public $title;

    /**
     * @description 跟踪链接的坑位ID（sg开头）
     *
     * @var string
     */
    public $trackId;
    protected $_name = [
        'trackUrl' => 'trackUrl',
        'title'    => 'title',
        'trackId'  => 'trackId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->trackUrl) {
            $res['trackUrl'] = $this->trackUrl;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->trackId) {
            $res['trackId'] = $this->trackId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return urlTrackConfig
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['trackUrl'])) {
            $model->trackUrl = $map['trackUrl'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['trackId'])) {
            $model->trackId = $map['trackId'];
        }

        return $model;
    }
}
