<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\AddHrmLegalEntityRequest;

use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\AddHrmLegalEntityRequest\ext\manageAddress;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\AddHrmLegalEntityRequest\ext\registrationAddress;
use AlibabaCloud\Tea\Model;

class ext extends Model
{
    /**
     * @var string
     */
    public $legalEntityEnName;

    /**
     * @var string
     */
    public $legalEntityEnShortName;

    /**
     * @var string
     */
    public $legalEntityType;

    /**
     * @var manageAddress
     */
    public $manageAddress;

    /**
     * @var registrationAddress
     */
    public $registrationAddress;

    /**
     * @var int
     */
    public $registrationDate;

    /**
     * @var string
     */
    public $unifiedSocialCreditCode;

    /**
     * @example 515200
     *
     * @var string
     */
    public $zipCode;
    protected $_name = [
        'legalEntityEnName' => 'legalEntityEnName',
        'legalEntityEnShortName' => 'legalEntityEnShortName',
        'legalEntityType' => 'legalEntityType',
        'manageAddress' => 'manageAddress',
        'registrationAddress' => 'registrationAddress',
        'registrationDate' => 'registrationDate',
        'unifiedSocialCreditCode' => 'unifiedSocialCreditCode',
        'zipCode' => 'zipCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->legalEntityEnName) {
            $res['legalEntityEnName'] = $this->legalEntityEnName;
        }
        if (null !== $this->legalEntityEnShortName) {
            $res['legalEntityEnShortName'] = $this->legalEntityEnShortName;
        }
        if (null !== $this->legalEntityType) {
            $res['legalEntityType'] = $this->legalEntityType;
        }
        if (null !== $this->manageAddress) {
            $res['manageAddress'] = null !== $this->manageAddress ? $this->manageAddress->toMap() : null;
        }
        if (null !== $this->registrationAddress) {
            $res['registrationAddress'] = null !== $this->registrationAddress ? $this->registrationAddress->toMap() : null;
        }
        if (null !== $this->registrationDate) {
            $res['registrationDate'] = $this->registrationDate;
        }
        if (null !== $this->unifiedSocialCreditCode) {
            $res['unifiedSocialCreditCode'] = $this->unifiedSocialCreditCode;
        }
        if (null !== $this->zipCode) {
            $res['zipCode'] = $this->zipCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ext
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['legalEntityEnName'])) {
            $model->legalEntityEnName = $map['legalEntityEnName'];
        }
        if (isset($map['legalEntityEnShortName'])) {
            $model->legalEntityEnShortName = $map['legalEntityEnShortName'];
        }
        if (isset($map['legalEntityType'])) {
            $model->legalEntityType = $map['legalEntityType'];
        }
        if (isset($map['manageAddress'])) {
            $model->manageAddress = manageAddress::fromMap($map['manageAddress']);
        }
        if (isset($map['registrationAddress'])) {
            $model->registrationAddress = registrationAddress::fromMap($map['registrationAddress']);
        }
        if (isset($map['registrationDate'])) {
            $model->registrationDate = $map['registrationDate'];
        }
        if (isset($map['unifiedSocialCreditCode'])) {
            $model->unifiedSocialCreditCode = $map['unifiedSocialCreditCode'];
        }
        if (isset($map['zipCode'])) {
            $model->zipCode = $map['zipCode'];
        }

        return $model;
    }
}
