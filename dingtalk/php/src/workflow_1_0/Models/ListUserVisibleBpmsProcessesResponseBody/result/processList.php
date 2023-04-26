<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ListUserVisibleBpmsProcessesResponseBody\result;

use AlibabaCloud\Tea\Model;

class processList extends Model
{
    /**
     * @example https://gw.xxxx/T-102-102.png
     *
     * @var string
     */
    public $iconUrl;

    /**
     * @example 物品领用
     *
     * @var string
     */
    public $name;

    /**
     * @example PROC-YMLA1-xxxx-11WFJ-1
     *
     * @var string
     */
    public $processCode;

    /**
     * @example https://aflow.dingtalk.com/dingtalk/mobile/homepage.htm?xxxx
     *
     * @var string
     */
    public $url;
    protected $_name = [
        'iconUrl'     => 'iconUrl',
        'name'        => 'name',
        'processCode' => 'processCode',
        'url'         => 'url',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->iconUrl) {
            $res['iconUrl'] = $this->iconUrl;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->processCode) {
            $res['processCode'] = $this->processCode;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return processList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['iconUrl'])) {
            $model->iconUrl = $map['iconUrl'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['processCode'])) {
            $model->processCode = $map['processCode'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
