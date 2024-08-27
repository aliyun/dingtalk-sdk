<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumInsertOrUpdateDirResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example {应用appId}_administeration
     *
     * @var string
     */
    public $bizGroup;

    /**
     * @example oaDirIdxxx
     *
     * @var string
     */
    public $dirId;
    protected $_name = [
        'bizGroup' => 'bizGroup',
        'dirId'    => 'dirId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizGroup) {
            $res['bizGroup'] = $this->bizGroup;
        }
        if (null !== $this->dirId) {
            $res['dirId'] = $this->dirId;
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
        if (isset($map['bizGroup'])) {
            $model->bizGroup = $map['bizGroup'];
        }
        if (isset($map['dirId'])) {
            $model->dirId = $map['dirId'];
        }

        return $model;
    }
}
