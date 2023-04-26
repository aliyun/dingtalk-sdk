<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\PageInnerAppHistoryVersionResponseBody;

use AlibabaCloud\Tea\Model;

class miniAppVersionList extends Model
{
    /**
     * @example 0.0.1
     *
     * @var string
     */
    public $appVersion;

    /**
     * @example 1
     *
     * @var int
     */
    public $appVersionId;

    /**
     * @example 0
     *
     * @var int
     */
    public $appVersionType;

    /**
     * @example 2023-01-01 00:00:00
     *
     * @var string
     */
    public $createTime;

    /**
     * @example 1
     *
     * @var string
     */
    public $miniAppId;

    /**
     * @var bool
     */
    public $miniAppOnPc;

    /**
     * @example 2023-01-01 00:00:00
     *
     * @var string
     */
    public $modifyTime;
    protected $_name = [
        'appVersion'     => 'appVersion',
        'appVersionId'   => 'appVersionId',
        'appVersionType' => 'appVersionType',
        'createTime'     => 'createTime',
        'miniAppId'      => 'miniAppId',
        'miniAppOnPc'    => 'miniAppOnPc',
        'modifyTime'     => 'modifyTime',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appVersion) {
            $res['appVersion'] = $this->appVersion;
        }
        if (null !== $this->appVersionId) {
            $res['appVersionId'] = $this->appVersionId;
        }
        if (null !== $this->appVersionType) {
            $res['appVersionType'] = $this->appVersionType;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->miniAppId) {
            $res['miniAppId'] = $this->miniAppId;
        }
        if (null !== $this->miniAppOnPc) {
            $res['miniAppOnPc'] = $this->miniAppOnPc;
        }
        if (null !== $this->modifyTime) {
            $res['modifyTime'] = $this->modifyTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return miniAppVersionList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appVersion'])) {
            $model->appVersion = $map['appVersion'];
        }
        if (isset($map['appVersionId'])) {
            $model->appVersionId = $map['appVersionId'];
        }
        if (isset($map['appVersionType'])) {
            $model->appVersionType = $map['appVersionType'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['miniAppId'])) {
            $model->miniAppId = $map['miniAppId'];
        }
        if (isset($map['miniAppOnPc'])) {
            $model->miniAppOnPc = $map['miniAppOnPc'];
        }
        if (isset($map['modifyTime'])) {
            $model->modifyTime = $map['modifyTime'];
        }

        return $model;
    }
}
