<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_global_e_c_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryNotableInfoResponseBody extends Model
{
    /**
     * @var string[]
     */
    public $adminUnionIds;

    /**
     * @var string
     */
    public $baseId;
    protected $_name = [
        'adminUnionIds' => 'adminUnionIds',
        'baseId' => 'baseId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->adminUnionIds) {
            $res['adminUnionIds'] = $this->adminUnionIds;
        }
        if (null !== $this->baseId) {
            $res['baseId'] = $this->baseId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryNotableInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['adminUnionIds'])) {
            if (!empty($map['adminUnionIds'])) {
                $model->adminUnionIds = $map['adminUnionIds'];
            }
        }
        if (isset($map['baseId'])) {
            $model->baseId = $map['baseId'];
        }

        return $model;
    }
}
