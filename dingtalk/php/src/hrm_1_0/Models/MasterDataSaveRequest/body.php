<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDataSaveRequest;

use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDataSaveRequest\body\fieldList;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDataSaveRequest\body\scope;
use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @description 数据变更时间戳，用以保证更新操作的顺序性
     *
     * @var int
     */
    public $bizTime;

    /**
     * @description 数据流水唯一标识，如流水号，用以唯一确认一条写入数据
     *
     * @var string
     */
    public $bizUk;

    /**
     * @description 业务域下的细分领域实体
     *
     * @var string
     */
    public $entityCode;

    /**
     * @description 数据字段列表
     *
     * @var fieldList[]
     */
    public $fieldList;

    /**
     * @description 业务域描述，系统分配
     *
     * @var scope
     */
    public $scope;

    /**
     * @description 员工id
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'bizTime'    => 'bizTime',
        'bizUk'      => 'bizUk',
        'entityCode' => 'entityCode',
        'fieldList'  => 'fieldList',
        'scope'      => 'scope',
        'userId'     => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizTime) {
            $res['bizTime'] = $this->bizTime;
        }
        if (null !== $this->bizUk) {
            $res['bizUk'] = $this->bizUk;
        }
        if (null !== $this->entityCode) {
            $res['entityCode'] = $this->entityCode;
        }
        if (null !== $this->fieldList) {
            $res['fieldList'] = [];
            if (null !== $this->fieldList && \is_array($this->fieldList)) {
                $n = 0;
                foreach ($this->fieldList as $item) {
                    $res['fieldList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->scope) {
            $res['scope'] = null !== $this->scope ? $this->scope->toMap() : null;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return body
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizTime'])) {
            $model->bizTime = $map['bizTime'];
        }
        if (isset($map['bizUk'])) {
            $model->bizUk = $map['bizUk'];
        }
        if (isset($map['entityCode'])) {
            $model->entityCode = $map['entityCode'];
        }
        if (isset($map['fieldList'])) {
            if (!empty($map['fieldList'])) {
                $model->fieldList = [];
                $n                = 0;
                foreach ($map['fieldList'] as $item) {
                    $model->fieldList[$n++] = null !== $item ? fieldList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['scope'])) {
            $model->scope = scope::fromMap($map['scope']);
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
