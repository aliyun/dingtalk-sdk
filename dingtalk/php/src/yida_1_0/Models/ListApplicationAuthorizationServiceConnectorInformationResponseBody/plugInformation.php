<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListApplicationAuthorizationServiceConnectorInformationResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListApplicationAuthorizationServiceConnectorInformationResponseBody\plugInformation\applications;
use AlibabaCloud\Tea\Model;

class plugInformation extends Model
{
    /**
     * @description pluginUuid
     *
     * @var string
     */
    public $plugUuid;

    /**
     * @description pluginTotalAmount
     *
     * @var int
     */
    public $plugTotalAmount;

    /**
     * @description pluginName
     *
     * @var string
     */
    public $plugName;

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
    public $plugPayType;

    /**
     * @description pluginUsageAmount
     *
     * @var int
     */
    public $plugUsageAmount;

    /**
     * @description pluginStatus
     *
     * @var int
     */
    public $plugStatus;

    /**
     * @description apps
     *
     * @var applications[]
     */
    public $applications;
    protected $_name = [
        'plugUuid'        => 'plugUuid',
        'plugTotalAmount' => 'plugTotalAmount',
        'plugName'        => 'plugName',
        'iconUrl'         => 'iconUrl',
        'plugPayType'     => 'plugPayType',
        'plugUsageAmount' => 'plugUsageAmount',
        'plugStatus'      => 'plugStatus',
        'applications'    => 'applications',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->plugUuid) {
            $res['plugUuid'] = $this->plugUuid;
        }
        if (null !== $this->plugTotalAmount) {
            $res['plugTotalAmount'] = $this->plugTotalAmount;
        }
        if (null !== $this->plugName) {
            $res['plugName'] = $this->plugName;
        }
        if (null !== $this->iconUrl) {
            $res['iconUrl'] = $this->iconUrl;
        }
        if (null !== $this->plugPayType) {
            $res['plugPayType'] = $this->plugPayType;
        }
        if (null !== $this->plugUsageAmount) {
            $res['plugUsageAmount'] = $this->plugUsageAmount;
        }
        if (null !== $this->plugStatus) {
            $res['plugStatus'] = $this->plugStatus;
        }
        if (null !== $this->applications) {
            $res['applications'] = [];
            if (null !== $this->applications && \is_array($this->applications)) {
                $n = 0;
                foreach ($this->applications as $item) {
                    $res['applications'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return plugInformation
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['plugUuid'])) {
            $model->plugUuid = $map['plugUuid'];
        }
        if (isset($map['plugTotalAmount'])) {
            $model->plugTotalAmount = $map['plugTotalAmount'];
        }
        if (isset($map['plugName'])) {
            $model->plugName = $map['plugName'];
        }
        if (isset($map['iconUrl'])) {
            $model->iconUrl = $map['iconUrl'];
        }
        if (isset($map['plugPayType'])) {
            $model->plugPayType = $map['plugPayType'];
        }
        if (isset($map['plugUsageAmount'])) {
            $model->plugUsageAmount = $map['plugUsageAmount'];
        }
        if (isset($map['plugStatus'])) {
            $model->plugStatus = $map['plugStatus'];
        }
        if (isset($map['applications'])) {
            if (!empty($map['applications'])) {
                $model->applications = [];
                $n                   = 0;
                foreach ($map['applications'] as $item) {
                    $model->applications[$n++] = null !== $item ? applications::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
