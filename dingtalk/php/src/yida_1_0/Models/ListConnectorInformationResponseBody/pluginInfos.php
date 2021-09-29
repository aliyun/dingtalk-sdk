<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListConnectorInformationResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListConnectorInformationResponseBody\pluginInfos\apps;
use AlibabaCloud\Tea\Model;

class pluginInfos extends Model
{
    /**
     * @description pluginUuid
     *
     * @var string
     */
    public $pluginUuid;

    /**
     * @description pluginTotalAmount
     *
     * @var int
     */
    public $pluginTotalAmount;

    /**
     * @description pluginName
     *
     * @var string
     */
    public $pluginName;

    /**
     * @description iconUrl
     *
     * @var string
     */
    public $iconUrl;

    /**
     * @description pluginPayType
     *
     * @var int
     */
    public $pluginPayType;

    /**
     * @description pluginUsageAmount
     *
     * @var int
     */
    public $pluginUsageAmount;

    /**
     * @description pluginStatus
     *
     * @var int
     */
    public $pluginStatus;

    /**
     * @description apps
     *
     * @var apps[]
     */
    public $apps;
    protected $_name = [
        'pluginUuid'        => 'pluginUuid',
        'pluginTotalAmount' => 'pluginTotalAmount',
        'pluginName'        => 'pluginName',
        'iconUrl'           => 'iconUrl',
        'pluginPayType'     => 'pluginPayType',
        'pluginUsageAmount' => 'pluginUsageAmount',
        'pluginStatus'      => 'pluginStatus',
        'apps'              => 'apps',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->pluginUuid) {
            $res['pluginUuid'] = $this->pluginUuid;
        }
        if (null !== $this->pluginTotalAmount) {
            $res['pluginTotalAmount'] = $this->pluginTotalAmount;
        }
        if (null !== $this->pluginName) {
            $res['pluginName'] = $this->pluginName;
        }
        if (null !== $this->iconUrl) {
            $res['iconUrl'] = $this->iconUrl;
        }
        if (null !== $this->pluginPayType) {
            $res['pluginPayType'] = $this->pluginPayType;
        }
        if (null !== $this->pluginUsageAmount) {
            $res['pluginUsageAmount'] = $this->pluginUsageAmount;
        }
        if (null !== $this->pluginStatus) {
            $res['pluginStatus'] = $this->pluginStatus;
        }
        if (null !== $this->apps) {
            $res['apps'] = [];
            if (null !== $this->apps && \is_array($this->apps)) {
                $n = 0;
                foreach ($this->apps as $item) {
                    $res['apps'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
        if (isset($map['pluginUuid'])) {
            $model->pluginUuid = $map['pluginUuid'];
        }
        if (isset($map['pluginTotalAmount'])) {
            $model->pluginTotalAmount = $map['pluginTotalAmount'];
        }
        if (isset($map['pluginName'])) {
            $model->pluginName = $map['pluginName'];
        }
        if (isset($map['iconUrl'])) {
            $model->iconUrl = $map['iconUrl'];
        }
        if (isset($map['pluginPayType'])) {
            $model->pluginPayType = $map['pluginPayType'];
        }
        if (isset($map['pluginUsageAmount'])) {
            $model->pluginUsageAmount = $map['pluginUsageAmount'];
        }
        if (isset($map['pluginStatus'])) {
            $model->pluginStatus = $map['pluginStatus'];
        }
        if (isset($map['apps'])) {
            if (!empty($map['apps'])) {
                $model->apps = [];
                $n           = 0;
                foreach ($map['apps'] as $item) {
                    $model->apps[$n++] = null !== $item ? apps::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
