<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class HrmMokaEventRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example /user/role/get
     *
     * @var string
     */
    public $bizId;

    /**
     * @description This parameter is required.
     *
     * @example {"a":"b"}
     *
     * @var string
     */
    public $content;
    protected $_name = [
        'bizId' => 'bizId',
        'content' => 'content',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizId) {
            $res['bizId'] = $this->bizId;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return HrmMokaEventRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }

        return $model;
    }
}
