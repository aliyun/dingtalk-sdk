<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainLabelDataUpsertRequest\params;

use AlibabaCloud\Tea\Model;

class labelDatas extends Model
{
    /**
     * @var string
     */
    public $labelCode;

    /**
     * @var string[]
     */
    public $labelValue;
    protected $_name = [
        'labelCode' => 'labelCode',
        'labelValue' => 'labelValue',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->labelCode) {
            $res['labelCode'] = $this->labelCode;
        }
        if (null !== $this->labelValue) {
            $res['labelValue'] = $this->labelValue;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return labelDatas
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['labelCode'])) {
            $model->labelCode = $map['labelCode'];
        }
        if (isset($map['labelValue'])) {
            if (!empty($map['labelValue'])) {
                $model->labelValue = $map['labelValue'];
            }
        }

        return $model;
    }
}
