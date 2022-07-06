<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryGroupInfoByMemberAuthResponseBody extends Model
{
    /**
     * @description 群内总人数
     *
     * @var int
     */
    public $memberCount;
    protected $_name = [
        'memberCount' => 'memberCount',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->memberCount) {
            $res['memberCount'] = $this->memberCount;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryGroupInfoByMemberAuthResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['memberCount'])) {
            $model->memberCount = $map['memberCount'];
        }

        return $model;
    }
}
