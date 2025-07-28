<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\CreateRuleRequest;

use AlibabaCloud\Tea\Model;

class customPlan extends Model
{
    /**
     * @var string[]
     */
    public $currentCategoryList;

    /**
     * @var int[]
     */
    public $deptIds;

    /**
     * @example test
     *
     * @var string
     */
    public $planName;

    /**
     * @var string[]
     */
    public $unSelectCategoryList;

    /**
     * @var string[]
     */
    public $userIds;
    protected $_name = [
        'currentCategoryList' => 'currentCategoryList',
        'deptIds' => 'deptIds',
        'planName' => 'planName',
        'unSelectCategoryList' => 'unSelectCategoryList',
        'userIds' => 'userIds',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->currentCategoryList) {
            $res['currentCategoryList'] = $this->currentCategoryList;
        }
        if (null !== $this->deptIds) {
            $res['deptIds'] = $this->deptIds;
        }
        if (null !== $this->planName) {
            $res['planName'] = $this->planName;
        }
        if (null !== $this->unSelectCategoryList) {
            $res['unSelectCategoryList'] = $this->unSelectCategoryList;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return customPlan
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['currentCategoryList'])) {
            if (!empty($map['currentCategoryList'])) {
                $model->currentCategoryList = $map['currentCategoryList'];
            }
        }
        if (isset($map['deptIds'])) {
            if (!empty($map['deptIds'])) {
                $model->deptIds = $map['deptIds'];
            }
        }
        if (isset($map['planName'])) {
            $model->planName = $map['planName'];
        }
        if (isset($map['unSelectCategoryList'])) {
            if (!empty($map['unSelectCategoryList'])) {
                $model->unSelectCategoryList = $map['unSelectCategoryList'];
            }
        }
        if (isset($map['userIds'])) {
            if (!empty($map['userIds'])) {
                $model->userIds = $map['userIds'];
            }
        }

        return $model;
    }
}
