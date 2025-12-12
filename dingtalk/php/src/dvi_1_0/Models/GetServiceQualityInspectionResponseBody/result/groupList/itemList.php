<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetServiceQualityInspectionResponseBody\result\groupList;

use AlibabaCloud\Tea\Model;

class itemList extends Model
{
    /**
     * @var string
     */
    public $flowName;

    /**
     * @var string
     */
    public $isHit;

    /**
     * @var string
     */
    public $reason;

    /**
     * @var int
     */
    public $score;

    /**
     * @var string
     */
    public $script;
    protected $_name = [
        'flowName' => 'flowName',
        'isHit' => 'isHit',
        'reason' => 'reason',
        'score' => 'score',
        'script' => 'script',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->flowName) {
            $res['flowName'] = $this->flowName;
        }
        if (null !== $this->isHit) {
            $res['isHit'] = $this->isHit;
        }
        if (null !== $this->reason) {
            $res['reason'] = $this->reason;
        }
        if (null !== $this->score) {
            $res['score'] = $this->score;
        }
        if (null !== $this->script) {
            $res['script'] = $this->script;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return itemList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['flowName'])) {
            $model->flowName = $map['flowName'];
        }
        if (isset($map['isHit'])) {
            $model->isHit = $map['isHit'];
        }
        if (isset($map['reason'])) {
            $model->reason = $map['reason'];
        }
        if (isset($map['score'])) {
            $model->score = $map['score'];
        }
        if (isset($map['script'])) {
            $model->script = $map['script'];
        }

        return $model;
    }
}
