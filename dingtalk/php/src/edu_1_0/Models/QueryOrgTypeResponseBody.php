<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryOrgTypeResponseBody extends Model
{
    /**
     * @example 1, "省级教育厅";2, "市级教育局";3, "区县教育局";4, "中心校";5, "普通学校"
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
