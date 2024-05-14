<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetTravelProcessDetailRequest extends Model
{
    /**
     * @example dingLamaXHExxxxxx
     *
     * @var string
     */
    public $processCorpId;

    /**
     * @description This parameter is required.
     *
     * @example 1fbmtOweRdqLamaXHExxxxxx
     *
     * @var string
     */
    public $processInstanceId;
    protected $_name = [
        'processCorpId'     => 'processCorpId',
        'processInstanceId' => 'processInstanceId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->processCorpId) {
            $res['processCorpId'] = $this->processCorpId;
        }
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetTravelProcessDetailRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['processCorpId'])) {
            $model->processCorpId = $map['processCorpId'];
        }
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }

        return $model;
    }
}
