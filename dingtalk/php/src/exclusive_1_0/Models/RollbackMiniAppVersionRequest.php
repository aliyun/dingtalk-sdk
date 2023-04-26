<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class RollbackMiniAppVersionRequest extends Model
{
    /**
     * @example 5000000003
     *
     * @var string
     */
    public $miniAppId;

    /**
     * @example 0.0.5
     *
     * @var string
     */
    public $rollbackVersion;

    /**
     * @example 0.0.4
     *
     * @var string
     */
    public $targetVersion;
    protected $_name = [
        'miniAppId'       => 'miniAppId',
        'rollbackVersion' => 'rollbackVersion',
        'targetVersion'   => 'targetVersion',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->miniAppId) {
            $res['miniAppId'] = $this->miniAppId;
        }
        if (null !== $this->rollbackVersion) {
            $res['rollbackVersion'] = $this->rollbackVersion;
        }
        if (null !== $this->targetVersion) {
            $res['targetVersion'] = $this->targetVersion;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RollbackMiniAppVersionRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['miniAppId'])) {
            $model->miniAppId = $map['miniAppId'];
        }
        if (isset($map['rollbackVersion'])) {
            $model->rollbackVersion = $map['rollbackVersion'];
        }
        if (isset($map['targetVersion'])) {
            $model->targetVersion = $map['targetVersion'];
        }

        return $model;
    }
}
