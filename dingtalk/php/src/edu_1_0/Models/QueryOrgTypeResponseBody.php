<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryOrgTypeResponseBody extends Model
{
    /**
     * @description 组织类型
     *
     * @var int
     */
    public $orgType;
    protected $_name = [
        'orgType' => 'orgType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->orgType) {
            $res['orgType'] = $this->orgType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryOrgTypeResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['orgType'])) {
            $model->orgType = $map['orgType'];
        }

        return $model;
    }
}
