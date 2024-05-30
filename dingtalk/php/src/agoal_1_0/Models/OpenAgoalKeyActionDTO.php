<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models;

use AlibabaCloud\Tea\Model;

class OpenAgoalKeyActionDTO extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 6444f5e9a4261c6e699dxxxx
     *
     * @var string
     */
    public $keyActionId;

    /**
     * @description This parameter is required.
     *
     * @example 测试
     *
     * @var string
     */
    public $title;

    /**
     * @description This parameter is required.
     *
     * @example https://agoal.dingtalk.com
     *
     * @var string
     */
    public $url;
    protected $_name = [
        'keyActionId' => 'keyActionId',
        'title'       => 'title',
        'url'         => 'url',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->keyActionId) {
            $res['keyActionId'] = $this->keyActionId;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OpenAgoalKeyActionDTO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['keyActionId'])) {
            $model->keyActionId = $map['keyActionId'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
