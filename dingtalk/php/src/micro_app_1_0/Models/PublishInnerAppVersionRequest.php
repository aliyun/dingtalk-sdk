<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class PublishInnerAppVersionRequest extends Model
{
    /**
     * @example 1
     *
     * @var int
     */
    public $appVersionId;

    /**
     * @var bool
     */
    public $miniAppOnPc;

    /**
     * @example xxx
     *
     * @var string
     */
    public $opUnionId;

    /**
     * @example online
     *
     * @var string
     */
    public $publishType;
    protected $_name = [
        'appVersionId' => 'appVersionId',
        'miniAppOnPc'  => 'miniAppOnPc',
        'opUnionId'    => 'opUnionId',
        'publishType'  => 'publishType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appVersionId) {
            $res['appVersionId'] = $this->appVersionId;
        }
        if (null !== $this->miniAppOnPc) {
            $res['miniAppOnPc'] = $this->miniAppOnPc;
        }
        if (null !== $this->opUnionId) {
            $res['opUnionId'] = $this->opUnionId;
        }
        if (null !== $this->publishType) {
            $res['publishType'] = $this->publishType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PublishInnerAppVersionRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appVersionId'])) {
            $model->appVersionId = $map['appVersionId'];
        }
        if (isset($map['miniAppOnPc'])) {
            $model->miniAppOnPc = $map['miniAppOnPc'];
        }
        if (isset($map['opUnionId'])) {
            $model->opUnionId = $map['opUnionId'];
        }
        if (isset($map['publishType'])) {
            $model->publishType = $map['publishType'];
        }

        return $model;
    }
}
