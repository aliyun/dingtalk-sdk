<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainLabelDataDeleteRequest;

use AlibabaCloud\Tea\Model;

class params extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $labelCodes;

    /**
     * @var string
     */
    public $workNo;
    protected $_name = [
        'labelCodes' => 'labelCodes',
        'workNo' => 'workNo',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->labelCodes) {
            $res['labelCodes'] = $this->labelCodes;
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
        if (isset($map['labelCodes'])) {
            if (!empty($map['labelCodes'])) {
                $model->labelCodes = $map['labelCodes'];
            }
        }
        if (isset($map['workNo'])) {
            $model->workNo = $map['workNo'];
        }

        return $model;
    }
}
