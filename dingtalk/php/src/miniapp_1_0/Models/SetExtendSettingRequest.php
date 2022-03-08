<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models;

use AlibabaCloud\Tea\Model;

class SetExtendSettingRequest extends Model
{
    /**
     * @var bool
     */
    public $buildH5Bundle;

    /**
     * @var string
     */
    public $miniAppId;
    protected $_name = [
        'buildH5Bundle' => 'buildH5Bundle',
        'miniAppId'     => 'miniAppId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->buildH5Bundle) {
            $res['buildH5Bundle'] = $this->buildH5Bundle;
        }
        if (null !== $this->miniAppId) {
            $res['miniAppId'] = $this->miniAppId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SetExtendSettingRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['buildH5Bundle'])) {
            $model->buildH5Bundle = $map['buildH5Bundle'];
        }
        if (isset($map['miniAppId'])) {
            $model->miniAppId = $map['miniAppId'];
        }

        return $model;
    }
}
