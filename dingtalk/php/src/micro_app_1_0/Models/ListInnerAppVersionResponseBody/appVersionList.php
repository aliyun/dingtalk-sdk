<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\ListInnerAppVersionResponseBody;

use AlibabaCloud\Tea\Model;

class appVersionList extends Model
{
    /**
     * @description 小程序版本号
     *
     * @var string
     */
    public $appVersion;

    /**
     * @description 小程序版本id，用于发布和回滚的版本唯一标识。
     *
     * @var int
     */
    public $appVersionId;

    /**
     * @description 小程序版本类型，0表示开发版本，2表示正式版本，3表示体验版本
     *
     * @var int
     */
    public $appVersionType;

    /**
     * @description 小程序版本创建事件，格式:yyyy-MM-dd HH:mm:ss
     *
     * @var string
     */
    public $createTime;

    /**
     * @description 小程序id
     *
     * @var string
     */
    public $miniAppId;

    /**
     * @description 是否支持PC端打开小程序，false表示只支持移动端，true表示既支持移动端又支持PC端
     *
     * @var bool
     */
    public $miniAppOnPc;

    /**
     * @description 小程序版本号更新时间，格式:yyyy-MM-dd HH:mm:ss
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
     * @return appVersionList
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
