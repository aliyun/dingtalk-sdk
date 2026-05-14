<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QuerySmartDeviceAiSceneByIdResponseBody\agent;

use AlibabaCloud\Tea\Model;

class isvAiScene extends Model
{
    /**
     * @var string
     */
    public $isvAppId;

    /**
     * @var int
     */
    public $isvAppState;

    /**
     * @var string
     */
    public $isvCorpId;

    /**
     * @var int
     */
    public $isvType;
    protected $_name = [
        'isvAppId' => 'isvAppId',
        'isvAppState' => 'isvAppState',
        'isvCorpId' => 'isvCorpId',
        'isvType' => 'isvType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->isvAppId) {
            $res['isvAppId'] = $this->isvAppId;
        }
        if (null !== $this->isvAppState) {
            $res['isvAppState'] = $this->isvAppState;
        }
        if (null !== $this->isvCorpId) {
            $res['isvCorpId'] = $this->isvCorpId;
        }
        if (null !== $this->isvType) {
            $res['isvType'] = $this->isvType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return isvAiScene
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['isvAppId'])) {
            $model->isvAppId = $map['isvAppId'];
        }
        if (isset($map['isvAppState'])) {
            $model->isvAppState = $map['isvAppState'];
        }
        if (isset($map['isvCorpId'])) {
            $model->isvCorpId = $map['isvCorpId'];
        }
        if (isset($map['isvType'])) {
            $model->isvType = $map['isvType'];
        }

        return $model;
    }
}
