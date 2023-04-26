<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDataSaveRequest;

use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDataSaveRequest\body\fieldList;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDataSaveRequest\body\scope;
use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @example 12312
     *
     * @var int
     */
    public $bizTime;

    /**
     * @example uk123
     *
     * @var string
     */
    public $bizUk;

    /**
     * @example base
     *
     * @var string
     */
    public $entityCode;

    /**
     * @var fieldList[]
     */
    public $fieldList;

    /**
     * @var scope
     */
    public $scope;

    /**
     * @example user123
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
