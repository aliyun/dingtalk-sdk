<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListConnectorInformationResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListConnectorInformationResponseBody\pluginInfos\apps;
use AlibabaCloud\Tea\Model;

class pluginInfos extends Model
{
    /**
     * @description apps
     *
     * @var apps[]
     */
    public $apps;

    /**
     * @description iconUrl
     *
     * @var string
     */
    public $iconUrl;

    /**
     * @description pluginName
     *
     * @var string
     */
    public $pluginName;

    /**
     * @description pluginPayType
     *
     * @var int
     */
    public $pluginPayType;

    /**
     * @description pluginStatus
     *
     * @var int
     */
    public $pluginStatus;

    /**
     * @description pluginTotalAmount
     *
     * @var int
     */
    public $pluginTotalAmount;

    /**
     * @description pluginUsageAmount
     *
     * @var int
     */
    public $pluginUsageAmount;

    /**
     * @description pluginUuid
     *
     * @var string
     */
    public $pluginUuid;
    protected $_name = [
        'apps'              => 'apps',
        'iconUrl'           => 'iconUrl',
        'pluginName'        => 'pluginName',
        'pluginPayType'     => 'pluginPayType',
        'pluginStatus'      => 'pluginStatus',
        'pluginTotalAmount' => 'pluginTotalAmount',
        'pluginUsageAmount' => 'pluginUsageAmount',
        'pluginUuid'        => 'pluginUuid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->apps) {
            $res['apps'] = [];
            if (null !== $this->apps && \is_array($this->apps)) {
                $n = 0;
                foreach ($this->apps as $item) {
                    $res['apps'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->iconUrl) {
            $res['iconUrl'] = $this->iconUrl;
        }
        if (null !== $this->pluginName) {
            $res['pluginName'] = $this->pluginName;
        }
        if (null !== $this->pluginPayType) {
            $res['pluginPayType'] = $this->pluginPayType;
        }
        if (null !== $this->pluginStatus) {
            $res['pluginStatus'] = $this->pluginStatus;
        }
        if (null !== $this->pluginTotalAmount) {
            $res['pluginTotalAmount'] = $this->pluginTotalAmount;
        }
        if (null !== $this->pluginUsageAmount) {
            $res['pluginUsageAmount'] = $this->pluginUsageAmount;
        }
        if (null !== $this->pluginUuid) {
            $res['pluginUuid'] = $this->pluginUuid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return pluginInfos
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['apps'])) {
            if (!empty($map['apps'])) {
                $model->apps = [];
                $n           = 0;
                foreach ($map['apps'] as $item) {
                    $model->apps[$n++] = null !== $item ? apps::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['iconUrl'])) {
            $model->iconUrl = $map['iconUrl'];
        }
        if (isset($map['pluginName'])) {
            $model->pluginName = $map['pluginName'];
        }
        if (isset($map['pluginPayType'])) {
            $model->pluginPayType = $map['pluginPayType'];
        }
        if (isset($map['pluginStatus'])) {
            $model->pluginStatus = $map['pluginStatus'];
        }
        if (isset($map['pluginTotalAmount'])) {
            $model->pluginTotalAmount = $map['pluginTotalAmount'];
        }
        if (isset($map['pluginUsageAmount'])) {
            $model->pluginUsageAmount = $map['pluginUsageAmount'];
        }
        if (isset($map['pluginUuid'])) {
            $model->pluginUuid = $map['pluginUuid'];
        }

        return $model;
    }
}
