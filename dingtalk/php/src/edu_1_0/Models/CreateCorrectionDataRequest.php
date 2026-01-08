<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateCorrectionDataRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $corpId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $correctedDataJsonUrl;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $taskCode;
    protected $_name = [
        'corpId' => 'corpId',
        'correctedDataJsonUrl' => 'correctedDataJsonUrl',
        'taskCode' => 'taskCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->correctedDataJsonUrl) {
            $res['correctedDataJsonUrl'] = $this->correctedDataJsonUrl;
        }
        if (null !== $this->taskCode) {
            $res['taskCode'] = $this->taskCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateCorrectionDataRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['correctedDataJsonUrl'])) {
            $model->correctedDataJsonUrl = $map['correctedDataJsonUrl'];
        }
        if (isset($map['taskCode'])) {
            $model->taskCode = $map['taskCode'];
        }

        return $model;
    }
}
