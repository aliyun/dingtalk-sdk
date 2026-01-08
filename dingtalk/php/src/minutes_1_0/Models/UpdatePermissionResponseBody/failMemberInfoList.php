<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\UpdatePermissionResponseBody;

use AlibabaCloud\Tea\Model;

class failMemberInfoList extends Model
{
    /**
     * @example 2
     *
     * @var int
     */
    public $memberType;

    /**
     * @example lJcRnm39OsU4jlFVmRGXXXXX
     *
     * @var string
     */
    public $memberUnionId;

    /**
     * @example 2
     *
     * @var int
     */
    public $policyId;
    protected $_name = [
        'memberType' => 'memberType',
        'memberUnionId' => 'memberUnionId',
        'policyId' => 'policyId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->memberType) {
            $res['memberType'] = $this->memberType;
        }
        if (null !== $this->memberUnionId) {
            $res['memberUnionId'] = $this->memberUnionId;
        }
        if (null !== $this->policyId) {
            $res['policyId'] = $this->policyId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return failMemberInfoList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['memberType'])) {
            $model->memberType = $map['memberType'];
        }
        if (isset($map['memberUnionId'])) {
            $model->memberUnionId = $map['memberUnionId'];
        }
        if (isset($map['policyId'])) {
            $model->policyId = $map['policyId'];
        }

        return $model;
    }
}
