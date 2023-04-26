<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\GetAppsResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @example D000183inventory
     *
     * @var string
     */
    public $appCode;

    /**
     * @example Installed
     *
     * @var string
     */
    public $appSource;

    /**
     * @example Enable
     *
     * @var string
     */
    public $appState;

    /**
     * @example 人事管理
     *
     * @var string
     */
    public $displayName;

    /**
     * @example dev001
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
