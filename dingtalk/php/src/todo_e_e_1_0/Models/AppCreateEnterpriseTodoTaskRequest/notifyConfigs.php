<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\AppCreateEnterpriseTodoTaskRequest;

use AlibabaCloud\Tea\Model;

class notifyConfigs extends Model
{
    /**
     * @var string
     */
    public $assistance;

    /**
     * @var string
     */
    public $dingNotify;
    protected $_name = [
        'assistance' => 'assistance',
        'dingNotify' => 'dingNotify',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->assistance) {
            $res['assistance'] = $this->assistance;
        }
        if (null !== $this->dingNotify) {
            $res['dingNotify'] = $this->dingNotify;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return notifyConfigs
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['assistance'])) {
            $model->assistance = $map['assistance'];
        }
        if (isset($map['dingNotify'])) {
            $model->dingNotify = $map['dingNotify'];
        }

        return $model;
    }
}
