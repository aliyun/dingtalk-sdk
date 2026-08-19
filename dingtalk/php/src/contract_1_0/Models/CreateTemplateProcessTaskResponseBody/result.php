<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\CreateTemplateProcessTaskResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $downloadUrl;

    /**
     * @var string
     */
    public $fillTaskId;

    /**
     * @var string
     */
    public $mode;

    /**
     * @var string
     */
    public $renderTaskId;
    protected $_name = [
        'downloadUrl' => 'downloadUrl',
        'fillTaskId' => 'fillTaskId',
        'mode' => 'mode',
        'renderTaskId' => 'renderTaskId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->downloadUrl) {
            $res['downloadUrl'] = $this->downloadUrl;
        }
        if (null !== $this->fillTaskId) {
            $res['fillTaskId'] = $this->fillTaskId;
        }
        if (null !== $this->mode) {
            $res['mode'] = $this->mode;
        }
        if (null !== $this->renderTaskId) {
            $res['renderTaskId'] = $this->renderTaskId;
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
        if (isset($map['downloadUrl'])) {
            $model->downloadUrl = $map['downloadUrl'];
        }
        if (isset($map['fillTaskId'])) {
            $model->fillTaskId = $map['fillTaskId'];
        }
        if (isset($map['mode'])) {
            $model->mode = $map['mode'];
        }
        if (isset($map['renderTaskId'])) {
            $model->renderTaskId = $map['renderTaskId'];
        }

        return $model;
    }
}
