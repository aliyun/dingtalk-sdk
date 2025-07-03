<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsalary_1_0\Models\ListSalaryCalculationResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vsalary_1_0\Models\ListSalaryCalculationResponseBody\result\data\dataList;
use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var dataList[]
     */
    public $dataList;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'dataList' => 'dataList',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dataList) {
            $res['dataList'] = [];
            if (null !== $this->dataList && \is_array($this->dataList)) {
                $n = 0;
                foreach ($this->dataList as $item) {
                    $res['dataList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dataList'])) {
            if (!empty($map['dataList'])) {
                $model->dataList = [];
                $n = 0;
                foreach ($map['dataList'] as $item) {
                    $model->dataList[$n++] = null !== $item ? dataList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
