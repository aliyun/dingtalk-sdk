<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vding_one_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vding_one_1_0\Models\UpdateFeedContentRequest\content;
use AlibabaCloud\Tea\Model;

class UpdateFeedContentRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var content
     */
    public $content;

    /**
     * @description This parameter is required.
     *
     * @example dd-one-work-eSo869uR9Vhse2sqTw3dDF
     *
     * @var string
     */
    public $feedId;

    /**
     * @description This parameter is required.
     *
     * @example ntThCP2X44FlskVliPIXPUQiEiE
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'content' => 'content',
        'feedId' => 'feedId',
        'unionId' => 'unionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = null !== $this->content ? $this->content->toMap() : null;
        }
        if (null !== $this->feedId) {
            $res['feedId'] = $this->feedId;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateFeedContentRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = content::fromMap($map['content']);
        }
        if (isset($map['feedId'])) {
            $model->feedId = $map['feedId'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
