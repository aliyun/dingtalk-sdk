<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\GetEmployeeRosterByFieldResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\GetEmployeeRosterByFieldResponseBody\result\fieldDataList;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example ding20a11xxx
     *
     * @var string
     */
    public $corpId;

    /**
     * @var fieldDataList[]
     */
    public $fieldDataList;

    /**
     * @var string
     */
    public $unionId;

    /**
     * @example 042519
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'corpId' => 'corpId',
        'fieldDataList' => 'fieldDataList',
        'unionId' => 'unionId',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->fieldDataList) {
            $res['fieldDataList'] = [];
            if (null !== $this->fieldDataList && \is_array($this->fieldDataList)) {
                $n = 0;
                foreach ($this->fieldDataList as $item) {
                    $res['fieldDataList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
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
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['fieldDataList'])) {
            if (!empty($map['fieldDataList'])) {
                $model->fieldDataList = [];
                $n = 0;
                foreach ($map['fieldDataList'] as $item) {
                    $model->fieldDataList[$n++] = null !== $item ? fieldDataList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
