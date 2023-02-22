<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class RollbackInnerAppVersionRequest extends Model
{
    /**
     * @description 操作人unionId
     *
     * @var string
     */
    public $opUnionId;

    /**
     * @description 小程序版本id
     *
     * @var int
     */
    public $versionId;
    protected $_name = [
        'opUnionId' => 'opUnionId',
        'versionId' => 'versionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->opUnionId) {
            $res['opUnionId'] = $this->opUnionId;
        }
        if (null !== $this->versionId) {
            $res['versionId'] = $this->versionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RollbackInnerAppVersionRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['opUnionId'])) {
            $model->opUnionId = $map['opUnionId'];
        }
        if (isset($map['versionId'])) {
            $model->versionId = $map['versionId'];
        }

        return $model;
    }
}
