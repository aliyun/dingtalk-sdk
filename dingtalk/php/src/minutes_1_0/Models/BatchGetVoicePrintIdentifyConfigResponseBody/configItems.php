<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\BatchGetVoicePrintIdentifyConfigResponseBody;

use AlibabaCloud\Tea\Model;

class configItems extends Model
{
    /**
     * @var bool
     */
    public $allowConfigVoicePrint;

    /**
     * @var bool
     */
    public $enableVoicePrint;

    /**
     * @var bool
     */
    public $hasVoicePrintRecord;

    /**
     * @var string
     */
    public $unionId;
    protected $_name = [
        'allowConfigVoicePrint' => 'allowConfigVoicePrint',
        'enableVoicePrint' => 'enableVoicePrint',
        'hasVoicePrintRecord' => 'hasVoicePrintRecord',
        'unionId' => 'unionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->allowConfigVoicePrint) {
            $res['allowConfigVoicePrint'] = $this->allowConfigVoicePrint;
        }
        if (null !== $this->enableVoicePrint) {
            $res['enableVoicePrint'] = $this->enableVoicePrint;
        }
        if (null !== $this->hasVoicePrintRecord) {
            $res['hasVoicePrintRecord'] = $this->hasVoicePrintRecord;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return configItems
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['allowConfigVoicePrint'])) {
            $model->allowConfigVoicePrint = $map['allowConfigVoicePrint'];
        }
        if (isset($map['enableVoicePrint'])) {
            $model->enableVoicePrint = $map['enableVoicePrint'];
        }
        if (isset($map['hasVoicePrintRecord'])) {
            $model->hasVoicePrintRecord = $map['hasVoicePrintRecord'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
