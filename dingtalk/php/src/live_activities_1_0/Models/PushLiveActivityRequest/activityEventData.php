<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_activities_1_0\Models\PushLiveActivityRequest;

use AlibabaCloud\Tea\Model;

class activityEventData extends Model
{
    /**
     * @var mixed
     */
    public $i18nContentState;

    /**
     * @example ride_with_alibtrip
     *
     * @var string
     */
    public $templateId;
    protected $_name = [
        'i18nContentState' => 'i18nContentState',
        'templateId' => 'templateId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->i18nContentState) {
            $res['i18nContentState'] = $this->i18nContentState;
        }
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return activityEventData
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['i18nContentState'])) {
            $model->i18nContentState = $map['i18nContentState'];
        }
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }

        return $model;
    }
}
