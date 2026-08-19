<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QueryContractCompareListResponseBody\result;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var string
     */
    public $comparativeFileName;

    /**
     * @var string
     */
    public $compareStatus;

    /**
     * @var string
     */
    public $compareTaskId;

    /**
     * @var string
     */
    public $gmtCreate;

    /**
     * @var string
     */
    public $gmtModified;

    /**
     * @var string
     */
    public $initiatorUid;

    /**
     * @var string
     */
    public $requestId;

    /**
     * @var string
     */
    public $result;

    /**
     * @var string
     */
    public $standardFileName;
    protected $_name = [
        'comparativeFileName' => 'comparativeFileName',
        'compareStatus' => 'compareStatus',
        'compareTaskId' => 'compareTaskId',
        'gmtCreate' => 'gmtCreate',
        'gmtModified' => 'gmtModified',
        'initiatorUid' => 'initiatorUid',
        'requestId' => 'requestId',
        'result' => 'result',
        'standardFileName' => 'standardFileName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->comparativeFileName) {
            $res['comparativeFileName'] = $this->comparativeFileName;
        }
        if (null !== $this->compareStatus) {
            $res['compareStatus'] = $this->compareStatus;
        }
        if (null !== $this->compareTaskId) {
            $res['compareTaskId'] = $this->compareTaskId;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
        }
        if (null !== $this->initiatorUid) {
            $res['initiatorUid'] = $this->initiatorUid;
        }
        if (null !== $this->requestId) {
            $res['requestId'] = $this->requestId;
        }
        if (null !== $this->result) {
            $res['result'] = $this->result;
        }
        if (null !== $this->standardFileName) {
            $res['standardFileName'] = $this->standardFileName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['comparativeFileName'])) {
            $model->comparativeFileName = $map['comparativeFileName'];
        }
        if (isset($map['compareStatus'])) {
            $model->compareStatus = $map['compareStatus'];
        }
        if (isset($map['compareTaskId'])) {
            $model->compareTaskId = $map['compareTaskId'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
        }
        if (isset($map['initiatorUid'])) {
            $model->initiatorUid = $map['initiatorUid'];
        }
        if (isset($map['requestId'])) {
            $model->requestId = $map['requestId'];
        }
        if (isset($map['result'])) {
            $model->result = $map['result'];
        }
        if (isset($map['standardFileName'])) {
            $model->standardFileName = $map['standardFileName'];
        }

        return $model;
    }
}
