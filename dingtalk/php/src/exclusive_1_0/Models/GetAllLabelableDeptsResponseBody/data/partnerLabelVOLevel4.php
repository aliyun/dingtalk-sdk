<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetAllLabelableDeptsResponseBody\data;

use AlibabaCloud\Tea\Model;

class partnerLabelVOLevel4 extends Model
{
    /**
     * @example 1234
     *
     * @var int
     */
    public $labelId;

    /**
     * @example 四级供应商
     *
     * @var string
     */
    public $labelName;

    /**
     * @example 4
     *
     * @var int
     */
    public $levelNum;
    protected $_name = [
        'labelId'   => 'labelId',
        'labelName' => 'labelName',
        'levelNum'  => 'levelNum',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->labelId) {
            $res['labelId'] = $this->labelId;
        }
        if (null !== $this->labelName) {
            $res['labelName'] = $this->labelName;
        }
        if (null !== $this->levelNum) {
            $res['levelNum'] = $this->levelNum;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return partnerLabelVOLevel4
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['labelId'])) {
            $model->labelId = $map['labelId'];
        }
        if (isset($map['labelName'])) {
            $model->labelName = $map['labelName'];
        }
        if (isset($map['levelNum'])) {
            $model->levelNum = $map['levelNum'];
        }

        return $model;
    }
}
