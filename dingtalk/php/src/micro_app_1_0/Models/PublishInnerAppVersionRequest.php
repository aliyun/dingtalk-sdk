<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class PublishInnerAppVersionRequest extends Model
{
    /**
     * @description 小程序是否在PC端发布，true表示发布移动端和PC端，false表示只发布移动端
     *
     * @var bool
     */
    public $miniAppOnPc;

    /**
     * @description 操作人unionId
     *
     * @var string
     */
    public $opUnionId;

    /**
     * @description 小程序发布类型，”online“表示发布线上版本，”experience“表示发布体验版本
     *
     * @var string
     */
    public $publishType;

    /**
     * @description 小程序版本id
     *
     * @var int
     */
    public $versionId;
    protected $_name = [
        'miniAppOnPc' => 'miniAppOnPc',
        'opUnionId'   => 'opUnionId',
        'publishType' => 'publishType',
        'versionId'   => 'versionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->miniAppOnPc) {
            $res['miniAppOnPc'] = $this->miniAppOnPc;
        }
        if (null !== $this->opUnionId) {
            $res['opUnionId'] = $this->opUnionId;
        }
        if (null !== $this->publishType) {
            $res['publishType'] = $this->publishType;
        }
        if (null !== $this->versionId) {
            $res['versionId'] = $this->versionId;
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
        if (isset($map['miniAppOnPc'])) {
            $model->miniAppOnPc = $map['miniAppOnPc'];
        }
        if (isset($map['opUnionId'])) {
            $model->opUnionId = $map['opUnionId'];
        }
        if (isset($map['publishType'])) {
            $model->publishType = $map['publishType'];
        }
        if (isset($map['versionId'])) {
            $model->versionId = $map['versionId'];
        }

        return $model;
    }
}
