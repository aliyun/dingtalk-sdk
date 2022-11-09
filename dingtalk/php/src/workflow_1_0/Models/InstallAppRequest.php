<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\InstallAppRequest\installOption;
use AlibabaCloud\Tea\Model;

class InstallAppRequest extends Model
{
    /**
     * @description 业务分组
     *
     * @var string
     */
    public $bizGroup;

    /**
     * @description 安装选项
     *
     *
     * @var installOption
     */
    public $installOption;

    /**
     * @description 安装的目录名称
     *
     * @var string
     */
    public $sourceDirName;
    protected $_name = [
        'bizGroup'      => 'bizGroup',
        'installOption' => 'installOption',
        'sourceDirName' => 'sourceDirName',
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
        if (null !== $this->installOption) {
            $res['installOption'] = null !== $this->installOption ? $this->installOption->toMap() : null;
        }
        if (null !== $this->sourceDirName) {
            $res['sourceDirName'] = $this->sourceDirName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return InstallAppRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizGroup'])) {
            $model->bizGroup = $map['bizGroup'];
        }
        if (isset($map['installOption'])) {
            $model->installOption = installOption::fromMap($map['installOption']);
        }
        if (isset($map['sourceDirName'])) {
            $model->sourceDirName = $map['sourceDirName'];
        }

        return $model;
    }
}
