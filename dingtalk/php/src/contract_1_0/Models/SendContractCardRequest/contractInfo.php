<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\SendContractCardRequest;

use AlibabaCloud\Tea\Model;

class contractInfo extends Model
{
    /**
     * @example HT_xxxxxxx
     *
     * @var string
     */
    public $contractCode;

    /**
     * @example 合同
     *
     * @var string
     */
    public $contractName;

    /**
     * @example 1242153453
     *
     * @var int
     */
    public $createTime;

    /**
     * @example 张三
     *
     * @var string
     */
    public $signUserName;
    protected $_name = [
        'contractCode' => 'contractCode',
        'contractName' => 'contractName',
        'createTime' => 'createTime',
        'signUserName' => 'signUserName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->contractCode) {
            $res['contractCode'] = $this->contractCode;
        }
        if (null !== $this->contractName) {
            $res['contractName'] = $this->contractName;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->signUserName) {
            $res['signUserName'] = $this->signUserName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return contractInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['contractCode'])) {
            $model->contractCode = $map['contractCode'];
        }
        if (isset($map['contractName'])) {
            $model->contractName = $map['contractName'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['signUserName'])) {
            $model->signUserName = $map['signUserName'];
        }

        return $model;
    }
}
