<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\ExportMinutesTaskResultRequest;

use AlibabaCloud\Tea\Model;

class summaryExportSetting extends Model
{
    /**
     * @var bool
     */
    public $enableBilingual;

    /**
     * @example zh
     *
     * @var string
     */
    public $targetLang;
    protected $_name = [
        'enableBilingual' => 'enableBilingual',
        'targetLang' => 'targetLang',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->enableBilingual) {
            $res['enableBilingual'] = $this->enableBilingual;
        }
        if (null !== $this->targetLang) {
            $res['targetLang'] = $this->targetLang;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return summaryExportSetting
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['enableBilingual'])) {
            $model->enableBilingual = $map['enableBilingual'];
        }
        if (isset($map['targetLang'])) {
            $model->targetLang = $map['targetLang'];
        }

        return $model;
    }
}
