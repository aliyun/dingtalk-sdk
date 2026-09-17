<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\UploadContractReviewByUrlResponseBody\data;

use AlibabaCloud\Tea\Model;

class recommended extends Model
{
    /**
     * @var string
     */
    public $contractType;

    /**
     * @var string
     */
    public $scale;

    /**
     * @var string
     */
    public $standpoint;
    protected $_name = [
        'contractType' => 'contract_type',
        'scale' => 'scale',
        'standpoint' => 'standpoint',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->contractType) {
            $res['contract_type'] = $this->contractType;
        }
        if (null !== $this->scale) {
            $res['scale'] = $this->scale;
        }
        if (null !== $this->standpoint) {
            $res['standpoint'] = $this->standpoint;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return recommended
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['contract_type'])) {
            $model->contractType = $map['contract_type'];
        }
        if (isset($map['scale'])) {
            $model->scale = $map['scale'];
        }
        if (isset($map['standpoint'])) {
            $model->standpoint = $map['standpoint'];
        }

        return $model;
    }
}
