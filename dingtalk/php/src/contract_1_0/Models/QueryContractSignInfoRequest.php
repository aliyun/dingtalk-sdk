<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryContractSignInfoRequest extends Model
{
    /**
     * @var string
     */
    public $contractBizId;

    /**
     * @var string
     */
    public $corpId;

    /**
     * @var string
     */
    public $staffId;
    protected $_name = [
        'contractBizId' => 'contractBizId',
        'corpId' => 'corpId',
        'staffId' => 'staffId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->contractBizId) {
            $res['contractBizId'] = $this->contractBizId;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->staffId) {
            $res['staffId'] = $this->staffId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryContractSignInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['contractBizId'])) {
            $model->contractBizId = $map['contractBizId'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['staffId'])) {
            $model->staffId = $map['staffId'];
        }

        return $model;
    }
}
