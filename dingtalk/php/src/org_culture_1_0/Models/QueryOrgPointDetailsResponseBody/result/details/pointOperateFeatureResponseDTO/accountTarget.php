<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryOrgPointDetailsResponseBody\result\details\pointOperateFeatureResponseDTO;

use AlibabaCloud\Tea\Model;

class accountTarget extends Model
{
    /**
     * @description 积分账号的类型
     * 企业账号：ORG, 员工账号：EMP
     * @var string
     */
    public $accountType;

    /**
     * @description 企业内名字
     *
     * @var string
     */
    public $empName;

    /**
     * @description 用户id
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'accountType' => 'accountType',
        'empName'     => 'empName',
        'userId'      => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->accountType) {
            $res['accountType'] = $this->accountType;
        }
        if (null !== $this->empName) {
            $res['empName'] = $this->empName;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return accountTarget
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accountType'])) {
            $model->accountType = $map['accountType'];
        }
        if (isset($map['empName'])) {
            $model->empName = $map['empName'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
