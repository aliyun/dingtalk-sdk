<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\GetAppsResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @description 应用编码
     *
     * @var string
     */
    public $appCode;

    /**
     * @description 应用的来源类型。Custom=自开发的、Installed=安装的
     *
     * @var string
     */
    public $appSource;

    /**
     * @description 应用状态。Enable=启用、Forbidden=禁用、Warring=预警
     *
     * @var string
     */
    public $appState;

    /**
     * @description 应用显示名称
     *
     * @var string
     */
    public $displayName;

    /**
     * @description 应用所属的解决方案名称
     *
     * @var string
     */
    public $solution;
    protected $_name = [
        'appCode'     => 'appCode',
        'appSource'   => 'appSource',
        'appState'    => 'appState',
        'displayName' => 'displayName',
        'solution'    => 'solution',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appCode) {
            $res['appCode'] = $this->appCode;
        }
        if (null !== $this->appSource) {
            $res['appSource'] = $this->appSource;
        }
        if (null !== $this->appState) {
            $res['appState'] = $this->appState;
        }
        if (null !== $this->displayName) {
            $res['displayName'] = $this->displayName;
        }
        if (null !== $this->solution) {
            $res['solution'] = $this->solution;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appCode'])) {
            $model->appCode = $map['appCode'];
        }
        if (isset($map['appSource'])) {
            $model->appSource = $map['appSource'];
        }
        if (isset($map['appState'])) {
            $model->appState = $map['appState'];
        }
        if (isset($map['displayName'])) {
            $model->displayName = $map['displayName'];
        }
        if (isset($map['solution'])) {
            $model->solution = $map['solution'];
        }

        return $model;
    }
}
