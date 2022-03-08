<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetClosingAccountsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetClosingAccountsResponseBody\result\closingAccountModel;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetClosingAccountsResponseBody\result\unsealClosingAccountModel;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 封账规则
     *
     * @var closingAccountModel
     */
    public $closingAccountModel;

    /**
     * @description 开关
     *
     * @var bool
     */
    public $switchOn;

    /**
     * @description 解封规则
     *
     * @var unsealClosingAccountModel
     */
    public $unsealClosingAccountModel;

    /**
     * @description 人员ID
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'closingAccountModel'       => 'closingAccountModel',
        'switchOn'                  => 'switchOn',
        'unsealClosingAccountModel' => 'unsealClosingAccountModel',
        'userId'                    => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->closingAccountModel) {
            $res['closingAccountModel'] = null !== $this->closingAccountModel ? $this->closingAccountModel->toMap() : null;
        }
        if (null !== $this->switchOn) {
            $res['switchOn'] = $this->switchOn;
        }
        if (null !== $this->unsealClosingAccountModel) {
            $res['unsealClosingAccountModel'] = null !== $this->unsealClosingAccountModel ? $this->unsealClosingAccountModel->toMap() : null;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['closingAccountModel'])) {
            $model->closingAccountModel = closingAccountModel::fromMap($map['closingAccountModel']);
        }
        if (isset($map['switchOn'])) {
            $model->switchOn = $map['switchOn'];
        }
        if (isset($map['unsealClosingAccountModel'])) {
            $model->unsealClosingAccountModel = unsealClosingAccountModel::fromMap($map['unsealClosingAccountModel']);
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
