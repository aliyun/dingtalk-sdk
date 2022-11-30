<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models;

use AlibabaCloud\Tea\Model;

class OpenMicroAppPackageRequest extends Model
{
    /**
     * @description 企业自建应用agentId
     *
     * @var int
     */
    public $agentId;
    protected $_name = [
        'agentId' => 'agentId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->agentId) {
            $res['agentId'] = $this->agentId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OpenMicroAppPackageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agentId'])) {
            $model->agentId = $map['agentId'];
        }

        return $model;
    }
}
