<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetPrintAppInfoResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetPrintAppInfoResponseBody\result\formInfoList;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 应用名称
     *
     * @var string
     */
    public $appName;

    /**
     * @description appType
     *
     * @var string
     */
    public $appType;

    /**
     * @description formInfoList
     *
     * @var formInfoList[]
     */
    public $formInfoList;

    /**
     * @description 图标链接
     *
     * @var string
     */
    public $iconUrl;
    protected $_name = [
        'appName'      => 'appName',
        'appType'      => 'appType',
        'formInfoList' => 'formInfoList',
        'iconUrl'      => 'iconUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appName) {
            $res['appName'] = $this->appName;
        }
        if (null !== $this->appType) {
            $res['appType'] = $this->appType;
        }
        if (null !== $this->formInfoList) {
            $res['formInfoList'] = [];
            if (null !== $this->formInfoList && \is_array($this->formInfoList)) {
                $n = 0;
                foreach ($this->formInfoList as $item) {
                    $res['formInfoList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->iconUrl) {
            $res['iconUrl'] = $this->iconUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appName'])) {
            $model->appName = $map['appName'];
        }
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['formInfoList'])) {
            if (!empty($map['formInfoList'])) {
                $model->formInfoList = [];
                $n                   = 0;
                foreach ($map['formInfoList'] as $item) {
                    $model->formInfoList[$n++] = null !== $item ? formInfoList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['iconUrl'])) {
            $model->iconUrl = $map['iconUrl'];
        }

        return $model;
    }
}
