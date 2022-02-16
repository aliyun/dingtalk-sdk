<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryRoleTagListResponseBody extends Model
{
    /**
     * @var string[]
     */
    public $roleList;
    protected $_name = [
        'roleList' => 'roleList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->roleList) {
            $res['roleList'] = $this->roleList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryRoleTagListResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['roleList'])) {
            if (!empty($map['roleList'])) {
                $model->roleList = $map['roleList'];
            }
        }

        return $model;
    }
}
