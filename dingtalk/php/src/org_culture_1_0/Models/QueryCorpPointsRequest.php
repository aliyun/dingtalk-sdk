<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryCorpPointsRequest extends Model
{
    /**
     * @description 操作用户ID
     *
     * @var string
     */
    public $optUserId;
    protected $_name = [
        'optUserId' => 'optUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->optUserId) {
            $res['optUserId'] = $this->optUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryCorpPointsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['optUserId'])) {
            $model->optUserId = $map['optUserId'];
        }

        return $model;
    }
}
