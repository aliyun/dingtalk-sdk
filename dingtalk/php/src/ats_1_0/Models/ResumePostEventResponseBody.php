<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models;

use AlibabaCloud\Tea\Model;

class ResumePostEventResponseBody extends Model
{
    /**
     * @var string
     */
    public $bizId;
    protected $_name = [
        'bizId' => 'bizId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizId) {
            $res['bizId'] = $this->bizId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ResumePostEventResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }

        return $model;
    }
}
