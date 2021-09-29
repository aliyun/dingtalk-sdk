<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListApplicationInformationResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListApplicationInformationResponseBody\applicationInformation\usagePlugins;
use AlibabaCloud\Tea\Model;

class applicationInformation extends Model
{
    /**
     * @description usagePlugins
     *
     * @var usagePlugins[]
     */
    public $usagePlugins;

    /**
     * @description appName
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
     * @description instanceUsageAmount
     *
     * @var int
     */
    public $instanceUsageAmount;

    /**
     * @description attachmentUsageAmount
     *
     * @var int
     */
    public $attachmentUsageAmount;
    protected $_name = [
        'usagePlugins'          => 'usagePlugins',
        'appName'               => 'appName',
        'appType'               => 'appType',
        'instanceUsageAmount'   => 'instanceUsageAmount',
        'attachmentUsageAmount' => 'attachmentUsageAmount',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->usagePlugins) {
            $res['usagePlugins'] = [];
            if (null !== $this->usagePlugins && \is_array($this->usagePlugins)) {
                $n = 0;
                foreach ($this->usagePlugins as $item) {
                    $res['usagePlugins'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->appName) {
            $res['appName'] = $this->appName;
        }
        if (null !== $this->appType) {
            $res['appType'] = $this->appType;
        }
        if (null !== $this->instanceUsageAmount) {
            $res['instanceUsageAmount'] = $this->instanceUsageAmount;
        }
        if (null !== $this->attachmentUsageAmount) {
            $res['attachmentUsageAmount'] = $this->attachmentUsageAmount;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return applicationInformation
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['usagePlugins'])) {
            if (!empty($map['usagePlugins'])) {
                $model->usagePlugins = [];
                $n                   = 0;
                foreach ($map['usagePlugins'] as $item) {
                    $model->usagePlugins[$n++] = null !== $item ? usagePlugins::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['appName'])) {
            $model->appName = $map['appName'];
        }
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['instanceUsageAmount'])) {
            $model->instanceUsageAmount = $map['instanceUsageAmount'];
        }
        if (isset($map['attachmentUsageAmount'])) {
            $model->attachmentUsageAmount = $map['attachmentUsageAmount'];
        }

        return $model;
    }
}
