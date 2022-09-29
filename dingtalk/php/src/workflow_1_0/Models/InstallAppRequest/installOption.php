<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\InstallAppRequest;

use AlibabaCloud\Tea\Model;

class installOption extends Model
{
    /**
     * @description 是否同步，目前只有同步
     *
     * @var bool
     */
    public $isSync;
    protected $_name = [
        'isSync' => 'isSync',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->isSync) {
            $res['isSync'] = $this->isSync;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return installOption
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['isSync'])) {
            $model->isSync = $map['isSync'];
        }

        return $model;
    }
}
