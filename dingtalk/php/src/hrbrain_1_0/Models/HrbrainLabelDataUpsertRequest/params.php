<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainLabelDataUpsertRequest;

use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainLabelDataUpsertRequest\params\labelDatas;
use AlibabaCloud\Tea\Model;

class params extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var labelDatas[]
     */
    public $labelDatas;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $workNo;
    protected $_name = [
        'labelDatas' => 'labelDatas',
        'workNo' => 'workNo',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->labelDatas) {
            $res['labelDatas'] = [];
            if (null !== $this->labelDatas && \is_array($this->labelDatas)) {
                $n = 0;
                foreach ($this->labelDatas as $item) {
                    $res['labelDatas'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->workNo) {
            $res['workNo'] = $this->workNo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return params
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['labelDatas'])) {
            if (!empty($map['labelDatas'])) {
                $model->labelDatas = [];
                $n = 0;
                foreach ($map['labelDatas'] as $item) {
                    $model->labelDatas[$n++] = null !== $item ? labelDatas::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['workNo'])) {
            $model->workNo = $map['workNo'];
        }

        return $model;
    }
}
