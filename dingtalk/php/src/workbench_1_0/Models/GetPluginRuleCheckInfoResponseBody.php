<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetPluginRuleCheckInfoResponseBody extends Model
{
    /**
     * @description 权限包code
     *
     * @var string
     */
    public $packCode;

    /**
     * @description 校验规则
     *
     * @var string
     */
    public $pluginRuleCheckDetail;
    protected $_name = [
        'packCode'              => 'packCode',
        'pluginRuleCheckDetail' => 'pluginRuleCheckDetail',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->packCode) {
            $res['packCode'] = $this->packCode;
        }
        if (null !== $this->pluginRuleCheckDetail) {
            $res['pluginRuleCheckDetail'] = $this->pluginRuleCheckDetail;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetPluginRuleCheckInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['packCode'])) {
            $model->packCode = $map['packCode'];
        }
        if (isset($map['pluginRuleCheckDetail'])) {
            $model->pluginRuleCheckDetail = $map['pluginRuleCheckDetail'];
        }

        return $model;
    }
}
